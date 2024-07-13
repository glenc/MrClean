# ToDo

- [ ] scaffold solutions
  - [ ] domain, app, infra, web
  - [ ] domain unit tests, app unit tests, app integration tests
- [ ] begin populating solutions
  - [ ] domain, app - simple
  - [ ] infra - understand dependencies
  - [ ] web - really understand dependencies
- [ ] create empty template and test
- [ ] create empty react app in web project
  - [ ] compare against reference project
  - [ ] understand differences
  - [ ] test api code generation
  - [ ] test api consumption in react app
- [ ] web stuff
  - [ ] nswag for API
    - [ ] can i view API in swagger UI even in web app?
  - [ ] nswag for client app
- [x] .editorconfig - respected by vscode? - seems to be working with vscode extension - also prettier ext
- [ ] examine reference for anything unknown - list below
- [ ] unknowns
  - [ ] what are the .liquid files?
  - [ ] .azure/bicep
  - [ ] .github
  - [ ] .scripts - appear to be for deployment - may scrap for now and incorporate later
  - [ ] global.json
  - [ ] test adding packages at sln level - what is right way to do this?
  - [ ] each folder in web project - diff between web api only vs. w/ client app
  - [ ] .http files - where do they come from?
  - [ ] .nswag file differences - need to understand this

## On Deck

- [ ] Clean solution scaffold
  - [ ] Empty classlib projects (app and tests) - no webapi
    - [x] src/Domain
    - [x] src/Application
    - [ ] src/Infrastructure (incomplete)
    - [x] tests/Domain.UnitTests
    - [x] tests/Application.UnitTests
  - [x] global.json?
  - [x] solution dependencies
  - [x] solution builds with dotnet build
  - [x] solution tests with dotnet test
  - [ ] turn into solution template
- [ ] Dive in to web solution reference vs. clean comparison
- [ ] Finish scaffold
  - [ ] src/Web
  - [ ] tests/Application.FunctionalTests (incomplete)
