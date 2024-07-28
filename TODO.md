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
- [ ] Finish scaffold
  - [ ] src/WebApi, src/WebClient
    - [ ] CORS
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

## Web Stuff

- [x] Empty web project w/ vite, react, ts
  - [x] Vite packaging
  - [x] Simple API from react
  - [x] HTTPS
  - [ ] HMR
  - [ ] Authentication? or wait for later
  - [x] Screw all this, just separate API and Vite/React projects
- [ ] Web api project
  - [x] Swagger from scratch
    - [ ] Swagger w/ authentication
- [x] API code gen - a bit of a hack, build to other project
- [ ] Finalize arch approach and template options
  - MPA vs. SPA
  - Project architecture

## Backlog

- [ ] MPA
  - [ ] Razor
  - [ ] MVC
  - [ ] Multiple PSAs
- [ ] API Code Gen - load by URL? is this a good idea?
- [ ] Autogen .http files? do i care?
