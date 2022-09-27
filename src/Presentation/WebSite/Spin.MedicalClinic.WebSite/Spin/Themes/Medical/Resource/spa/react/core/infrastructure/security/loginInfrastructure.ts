import { ResponseLogin } from '../../domain/entity/security/responseLogin';
import { ILoginInfrastructure } from '../../domain/interfaces/infrastructure/iLoginInfrastructure';
import { IRequestLogin } from '../../domain/interfaces/security/iRequestLogin';
import { IResponseLogin } from '../../domain/interfaces/security/iResponseLogin';
import axios from 'axios';

/**
 * @class Login Infrastructure
 */
export class LoginInfrastructure implements ILoginInfrastructure{

    /**
     * Login User
     * @param request inforamtion user
     */
    public async Handler(request: IRequestLogin): Promise<IResponseLogin> {

        await axios.post('/Api/Security/Login', {
            params: {
                
            }
        })
        .then((response) => {
            console.log('2. server response:' + response.data.unique)
            //this.valid = response.data.unique;
        });


        //console.log("send info");
       return new ResponseLogin();
    }

}