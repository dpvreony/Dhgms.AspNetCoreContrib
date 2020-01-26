# 4. Dependency Management by Dependabot

Date: 2020-01-26

## Status

Accepted

## Context

Updates of upstream dependencies need to be managed.

## Decision

We will use Dependabot as part of the github integration.
Dependabot will produce Pull Requests per package.

## Consequences

We will be prompted to update to packages when they are released.
Breaking changes may block Pull Requests and require intervention.