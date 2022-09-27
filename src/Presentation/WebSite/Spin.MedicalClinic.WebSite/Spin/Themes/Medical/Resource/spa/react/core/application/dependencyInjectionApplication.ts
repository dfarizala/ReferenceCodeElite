import {container} from "tsyringe";
import { SecurityApplication } from './security/SecurityApplication';

/**
 * @class DependencyInjectionApplication
 */
export class DependencyInjectionApplication {  
    /**
     * @static DependencyInjectionApplication
     */
    public static DependencyInjectionStartup(): void {
        container.register("ISecurityApplication", {useClass: SecurityApplication});
    }
}