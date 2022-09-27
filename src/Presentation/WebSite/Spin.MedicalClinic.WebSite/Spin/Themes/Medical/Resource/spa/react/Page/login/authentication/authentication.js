"use strict";
//import "reflect-metadata";
//import { container } from "tsyringe";
Object.defineProperty(exports, "__esModule", { value: true });
exports.StartupLogin = void 0;
const startupMedical_1 = require("../../../startupMedical");
const spinReact_1 = require("../../../../../../../../SPA/React/base/spinReact");
//import { SecurityApplication } from '../../../core/application/security/securityApplication';
//import { ILoginApplication } from '../../../core/domain/interfaces/application/iLoginApplication';
//import { RequestLogin } from "../../../core/domain/entity/security/requestLogin";
class StartupLogin extends startupMedical_1.StartupMedical {
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
exports.StartupLogin = StartupLogin;
spinReact_1.SpinReact.start(new StartupLogin());
//# sourceMappingURL=authentication.js.map