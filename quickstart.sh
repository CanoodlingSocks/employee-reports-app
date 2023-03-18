#!/bin/bash

# Start the .NET Core Web API backend
cd Backend
dotnet run &

# Save the PID of the dotnet process
DOTNET_PID=$!

# Start the React frontend
cd ../client
npm start 