import { IRequestLogin } from '../security/iRequestLogin';
import { IResponseLogin } from '../security/iResponseLogin';

/**
 * @class RequestLogin
 */
export interface ILoginApplication{

    /**
     * Login User
     * @param request inforamtion user
     */
    Login(request:IRequestLogin): Promise<IResponseLogin>;
}