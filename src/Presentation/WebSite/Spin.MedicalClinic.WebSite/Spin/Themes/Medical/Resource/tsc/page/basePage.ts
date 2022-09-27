import { PageController } from "../../../../Shared/spin-sys/tsc/page/page";

/**
 * Base page abstract class
 */
export abstract class BasePage extends PageController {
    
  

    constructor() {
        super();
      
        this.listenEvent();
    }

    /**
     * Listen scroll and resize events
     */
    private listenEvent(): void {
       
    }
}