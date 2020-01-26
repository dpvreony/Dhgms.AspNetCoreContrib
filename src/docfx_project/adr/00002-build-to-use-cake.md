# 2. Continous Integration Builds to use Cake Build tools 

Date: 2020-01-26

## Status

Accepted

## Context

We need to automate the generation of build artifacts/

## Decision

The build will use Cake.Net and be triggered by .\build.ps1
Build will focus on build and testing of artifacts.
Build will output artifacts, build logs and visual studio bin logs.
Build will NOT be used for deployment of artifacts.

## Consequences

Knowledge of Cake and Powershell required. Documentation available at https://cakebuild.net/docs/