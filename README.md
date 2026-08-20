# Task Manager (Console CRUD)

A simple console application built in C# to practice the fundamentals of the language — 
particularly the four basic CRUD operations (Create, Read, Update, Delete) using an 
in-memory data structure instead of a database.

## About

This project was built as a learning exercise while studying C# fundamentals: 
value/reference types, collections, LINQ basics, static members, nullable reference 
types, and exception handling. Rather than jumping straight into a database or a web 
API, the goal here was to isolate the CRUD logic itself and understand it at the 
language level first.

## Features

- **Add** a new task with a title
- **List** all tasks, showing completion status
- **Finish** a task by its ID
- **Remove** a task by its ID
- Input validation (empty titles, invalid IDs, non-existent tasks)

## How it works

Tasks are stored in a `List<Task>` that lives for the duration of the program's 
execution — there's no persistence layer, so all data resets when the app closes. 
This was intentional: the focus of this project is the CRUD logic itself, not 
storage or architecture.

## Commands

| Command  | Action                          |
|----------|----------------------------------|
| `add`    | Create a new task                |
| `list`   | Show all tasks                   |
| `finish` | Mark a task as completed         |
| `exit`   | Close the application            |

## Tech

- C#
- .NET (console app)

## What's next

Planned improvements as I continue through my C# learning roadmap:
- Persisting tasks to a file (JSON) or a database
- Splitting logic into services/repositories (moving beyond a single `Program` class)
- Unit tests

---

*This project is part of my personal study roadmap for learning C#, focusing on 
language fundamentals before moving into OOP and more advanced topics.*
