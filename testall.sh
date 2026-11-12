#!/bin/bash

# Iterate over all subdirectories in the current directory
for dir in */; do
    # Check if it's actually a directory (not a file)
    if [ -d "$dir" ]; then
        echo "Running $dir"
        echo "-------------------"
        cd "$dir"
        dotnet run
        cd ..
        echo ""  # Add a blank line for readability
    fi
done
