@echo off

pushd %~dp0

pushd Frontend
call npm run build
popd

if exist Publish rd /q /s Publish

pushd Backend
dotnet publish src\Test.Backend\Test.Backend.csproj -c Release -o ..\Publish
popd

popd