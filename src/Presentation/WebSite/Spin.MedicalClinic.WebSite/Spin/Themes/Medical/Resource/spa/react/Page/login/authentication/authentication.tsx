//import "reflect-metadata";
//import { container } from "tsyringe";


import { StartupMedical } from "../../../startupMedical"
import { SpinReact } from "../../../../../../../../SPA/React/base/spinReact";
//import { SecurityApplication } from '../../../core/application/security/securityApplication';
//import { ILoginApplication } from '../../../core/domain/interfaces/application/iLoginApplication';
//import { RequestLogin } from "../../../core/domain/entity/security/requestLogin";

export class StartupLogin extends StartupMedical {
    constructor() {
        super(null);

        /*
        var instance = container.resolve<ILoginApplication>("ISecurityApplication");
        console.log(instance);

        var request = new RequestLogin();
        request.UserName = "admin";
        request.Password = "admin";

        instance.Login(request).then(result => {
            console.log(result);
        });
        */
    }
}

SpinReact.start(new StartupLogin());