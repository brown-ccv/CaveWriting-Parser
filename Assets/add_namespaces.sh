#!/bin/bash

cd "Classes/"

# Append text to beginning of each cs file

# for f in *.cs; do 
#     echo "using UnityEngine;" > tmpfile
#     echo "using System.Xml.Serialization;" >> tmpfile
#     echo >> tmpfile
#     cat $f >> tmpfile
#     mv tmpfile $f
# done

# Remove first line from each cs file

# for f in *.cs; do
#     tail -n +2 "$f" > "$f.tmp" && mv "$f.tmp" "$f"
# done