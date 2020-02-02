# 5. Continous Integration Builds to use Appveyor 

Date: 2020-02-02

## Status

Under Review

## Context

We need to automate the generation of build artifacts.

## Decision

The build will use be hosted on AppVeyor.
AppVeyor has webhooks from the github project.
The repository contains a YAML config file for AppVeyor.

## Consequences

Knowledge of AppVeyor and YAML required.