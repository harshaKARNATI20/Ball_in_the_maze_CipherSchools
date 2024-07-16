@echo off
set /p commit_message="Enter commit message: "

git add .
git commit -m "%commit_message%"
git push -u origin main

echo Changes added, committed, and pushed to remote repository.
