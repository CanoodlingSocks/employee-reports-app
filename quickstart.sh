#!/bin/bash

# Start the .NET Core Web API backend
cd Backend
dotnet run &

# Save the PID of the dotnet process
DOTNET_PID=$!

# Start the React frontend
cd ../client
npm start &

# Save the PID of the npm process
NPM_PID=$!

# Wait for user input to stop the servers
read -p "Press any key to stop the servers..."

# Kill the dotnet and npm processes
kill $DOTNET_PID
kill $NPM_PID