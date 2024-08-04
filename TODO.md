# ToDo

- [x] Clean solution scaffold
  - [x] Empty classlib projects (app and tests) - no webapi
    - [x] src/Domain
    - [x] src/Application
    - [x] src/Infrastructure (partial)
    - [x] tests/Domain.UnitTests
    - [x] tests/Application.UnitTests
    - [x] tests/Application.FunctionalTests (partial)
  - [x] global.json?
  - [x] solution dependencies
  - [x] solution builds with dotnet build
  - [x] solution tests with dotnet test
  - [x] turn into solution template
- [x] Dive in to web solution reference vs. clean comparison
- [x] Try to start picking apart the default web solution
  - [x] Remove dependencies, see what breaks
  - [x] Try using typescript
  - [x] Call generated API
- [x] Finish scaffold
  - [x] src/WebApi, src/WebClient
    - [x] CORS
    - [ ] Auth
  - [x] src/Infrastructure (complete)
  - [x] tests/Application.FunctionalTests (complete)
- [x] Populate scaffold
  - [x] entities etc and tests
  - [x] db migration stuff
- [x] Add template actions
  - [x] use case
  - [x] use case tests
  - [x] entity
  - [x] entity test

## Auth Work

- [ ] Login UI
- [ ] Context and routing
- [ ] API auth baked in

## Backlog

- [ ] MPA
  - [ ] Razor
  - [ ] MVC
  - [ ] Multiple PSAs
- [ ] API Code Gen - load by URL? is this a good idea?
- [ ] Autogen .http files? do i care?
- [ ] Client Frameworks
  - [ ] React
  - [x] React-ts
  - [ ] Vue
  - [x] Vue-ts
