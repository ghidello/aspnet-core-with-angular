# TestFrontend

This project was generated with [Angular CLI](https://github.com/angular/angular-cli) version 13.1.2.

## Base HREF

The application url will be **https://iis.intranet.servizi/IP001/** so probably there will be a problem with the base href and the other assets urls. 

This can be a possible fix: [Set base href from an environment variable with ng build](https://stackoverflow.com/a/67038907)

```json
{
    "configurations": {
        "production": {        
            "baseHref": "__BASE_HREF__",
            "deployUrl": "__DEPLOY_URL__",
        }
    }
}
```

