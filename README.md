# AI Task Assistant

A learning portfolio project: an ASP.NET Core Web API that will use an LLM
to translate natural-language requests into one of three allowlisted task actions:

- list tasks;
- create a task;
- mark an existing task as completed.

## Status

Project scaffold only. Task storage, LLM integration, tool calling, and tests
for application behavior are not implemented yet.

## Planned stack

- C#
- ASP.NET Core Web API
- Entity Framework Core
- SQLite
- LLM API with structured function calling

## Security boundary

The finished application will expose only three predefined task tools.
It will not allow arbitrary SQL, code execution, shell commands, or file access.
API credentials will not be stored in the repository.