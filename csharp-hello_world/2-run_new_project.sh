#!/usr/bin/env bash

new_project="2-new_project"
mkdir "$new_project"
cd "$new_project"

dotnet new console
dotnet build
dotnet run