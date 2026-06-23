# Recipe Book

Recipe Book is a Flask web application that allows users to create and manage their own collection of recipes.

Users can register for an account, log in, add recipes, edit them, delete them, and save their favorite recipes for quick access.

## Features

- User registration and login
- Secure password hashing with Werkzeug
- Add, edit, and delete recipes
- Favorite and unfavorite recipes
- Separate recipe collection for each user
- Session-based authentication

## Built With

- Python
- Flask
- SQLite
- HTML/CSS
- Jinja2
- Flask-Session
- CS50 SQL Library

## Database

The application uses three tables:

- `users` – stores account information
- `recipes` – stores recipe details
- `favorites` – stores users' favorite recipes

## Running the Project

Install the required packages:

```bash
pip install flask flask-session cs50 werkzeug
```

Run the application:

```bash
flask run
```

Open your browser and visit:

```text
http://127.0.0.1:5000
```

## Project Structure

```text
Recipe-Book/
├── static/
├── templates/
├── app.py
├── recipe.db
└── README.md
```

## Author

**Lojine Gad**
