from cs50 import SQL
from functools import wraps
from flask import Flask, render_template, redirect, request, session
from flask_session import Session
from werkzeug.security import check_password_hash, generate_password_hash

app = Flask(__name__)

app.config["SESSION_PERMANENT"] = False
app.config["SESSION_TYPE"] = "filesystem"
Session(app)

db = SQL("sqlite:///recipe.db")
def login_required(f):
    @wraps(f)
    def decorated_function(*args, **kwargs):
        if session.get("user_id") is None:
            return redirect("/login")
        return f(*args, **kwargs)
    return decorated_function
@app.route("/")
@login_required
def index():
    recipes = db.execute("SELECT * FROM recipes WHERE user_id = ?", (session["user_id"],))
    return render_template("index.html", recipes=recipes)

@app.route("/login",methods = ["GET","POST"])
def login():
    if request.method == "POST":
        session.clear()

        username = request.form.get("username")
        password = request.form.get("password")

        rows = db.execute("SELECT * FROM users WHERE username = ?",username)

        if len(rows)!= 1 or not check_password_hash(rows[0]["hash"], password):
            return render_template("apology.html", message = "Invalid username or password")

        session["user_id"] = rows[0]["id"]
        return redirect("/")
    return render_template("login.html")
@app.route("/favorites")
@login_required
def favorites():
    recipes = db.execute("""
        SELECT recipes.* FROM recipes JOIN favorites ON recipes.id = favorites.recipe_id
        WHERE favorites.user_id = ?
    """, session["user_id"])
    return render_template("favorites.html", recipes=recipes)


@app.route("/favorite/<int:recipe_id>", methods=["POST"])
@login_required
def favorite(recipe_id):
    recipe = db.execute("SELECT * FROM favorites WHERE user_id = ? AND recipe_id = ?", session["user_id"], recipe_id)
    if recipe:
        db.execute("DELETE FROM favorites WHERE user_id = ? AND recipe_id = ?", session["user_id"], recipe_id)
    else:
        db.execute("INSERT INTO favorites (user_id, recipe_id) VALUES (?, ?)", session["user_id"], recipe_id)
    return redirect("/")

@app.route("/logout")
def logout():
    session.clear()
    return redirect("/")

@app.route("/add", methods=["GET", "POST"])
@login_required
def add():
    if request.method == "POST":
        title = request.form.get("title")
        ingredients = request.form.get("ingredients")
        instructions = request.form.get("instructions")
        category = request.form.get("category")

        if not title or not ingredients or not instructions:
            return render_template("apology.html", message="All fields required")

        db.execute(
            "INSERT INTO recipes (user_id, title, ingredients, instructions, category) VALUES (?, ?, ?, ?, ?)",
            session["user_id"], title, ingredients, instructions, category
        )
        return redirect("/")

    return render_template("add.html")

@app.route("/edit/<int:recipe_id>",methods = ["GET","POST"])
@login_required
def edit(recipe_id):
    recipe = db.execute("SELECT * FROM recipes WHERE id = ? AND user_id = ?",recipe_id,session["user_id"])
    if not recipe:
        return render_template("apology.html",message = "Recipe not found")

    recipe = recipe[0]
    if request.method == "POST":
        title = request.form.get("title")
        ingredients = request.form.get("ingredients")
        instructions = request.form.get("instructions")
        category = request.form.get("category")

        if not title or not ingredients or not instructions:
            return render_template("apology.html", message="All fields required")

        db.execute(
            "UPDATE recipes SET title = ?, ingredients = ?, instructions = ?, category = ? WHERE id = ? AND user_id = ?",
            title, ingredients, instructions, category, recipe_id, session["user_id"]
        )
        return redirect("/")

    return render_template("edit.html", recipe=recipe)
@app.route("/delete/<int:recipe_id>", methods=["POST"])
@login_required
def delete(recipe_id):
    db.execute("DELETE FROM recipes WHERE id = ? AND user_id = ?", recipe_id, session["user_id"])
    return redirect("/")
@app.route("/register",methods = ["GET","POST"])
def register():
    if request.method == "POST":
        username = request.form.get("username")
        password = request.form.get("password")
        confirmation = request.form.get("confirmation")

        if not username or not password or not confirmation:
            return render_template("apology.html",message = "All fields required")

        if password!=confirmation:
            return render_template("apology.html",message = "Passwords dont match")
        rows = db.execute("SELECT id FROM users WHERE username = ?",username)
        if len(rows) >0:
            return render_template("apology.html",message = "Username taken")

        hash_pw = generate_password_hash(password)
        db.execute("INSERT INTO users(username,hash) VALUES (?,?)",username,hash_pw)
        return redirect("/login")

    return render_template("register.html")

if __name__ == "__main__":
    app.run(debug=True)
