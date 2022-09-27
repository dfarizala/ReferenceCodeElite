import { Startup } from  "./base/startup"
import { App } from "./components/App"
import { SpinReact } from   "./base/spinReact"

export class StartupBase extends Startup{
	constructor(){
		super(App)
	}
}

SpinReact.start(new StartupBase());