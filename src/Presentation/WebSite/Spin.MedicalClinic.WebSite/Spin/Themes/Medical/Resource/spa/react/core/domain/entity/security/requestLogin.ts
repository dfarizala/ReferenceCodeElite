import { IRequestLogin } from '../../interfaces/security/iRequestLogin';


/**
 * @class RequestLogin
 */
export class RequestLogin implements IRequestLogin {

    /**
     * User Name
     */
    public UserName: string;

    /**
     * Password
     */
    public Password: string;
}