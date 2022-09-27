import { ILoginApplication } from "../../domain/interfaces/application/iLoginApplication";
import { IRequestLogin } from "../../domain/interfaces/security/iRequestLogin";
import { IResponseLogin } from "../../domain/interfaces/security/iResponseLogin";
import { ILoginInfrastructure } from "../../domain/interfaces/infrastructure/iLoginInfrastructure";
import {injectable, inject, injectAll} from "tsyringe";

/**
 * @class LoginApplication
 */
@injectable()
export class SecurityApplication implements ILoginApplication {
  private _loginHandler: ILoginInfrastructure;

  /**
   * constructor base
   */
  public constructor(@inject("ILoginInfrastructure") loginHandler: ILoginInfrastructure) {
    this._loginHandler = loginHandler;
  }

  /**
   * Login user
   * @param request information user
   */
  public async Login(request: IRequestLogin): Promise<IResponseLogin> {
    return await this._loginHandler.Handler(request);
  }
}
