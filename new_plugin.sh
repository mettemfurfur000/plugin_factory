#!/bin/bash

NAME=$1

mkdir -p ${NAME}/src/config
cp makefile ${NAME}/
cp watch.sh ${NAME}/
cp Main.cs ${NAME}/src
cp Config.cs ${NAME}/src/config
cp template.csproj ${NAME}/${NAME}.csproj

find ${NAME}/ -type f -name "*" -exec sed -i "s/template/${NAME}/g" {} +
find ${NAME}/ -type f -name "*" -exec sed -i "s/username/${USER}/g" {} +
