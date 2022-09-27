import { IResponseLogin } from '../security/iResponseLogin';
import { IRequestLogin } from '../security/iRequestLogin';
/**
 * @class Security Infrastructure
 */
export interface ILoginInfrastructure{
    /**
     * Login User
     * @param request inforamtion user
     */
    Handler(request:IRequestLogin):Promise<IResponseLogin>;
}   