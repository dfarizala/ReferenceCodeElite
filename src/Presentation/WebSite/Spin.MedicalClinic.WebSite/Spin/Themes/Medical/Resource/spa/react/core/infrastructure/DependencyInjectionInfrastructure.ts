import {container} from "tsyringe";
import { LoginInfrastructure } from './security/loginInfrastructure';
/**
 * @class DependencyInjectionInfrastructure
 */
 export class DependencyInjectionInfrastructure {  
    /**
     * @static DependencyInjectionInfrastructure
     */
    public static DependencyInjectionStartup(): void {
        container.register("ILoginInfrastructure", {useClass: LoginInfrastructure});
    }
}