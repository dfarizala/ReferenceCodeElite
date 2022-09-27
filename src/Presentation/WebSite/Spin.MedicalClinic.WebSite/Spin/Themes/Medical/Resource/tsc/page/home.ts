import { BasePage } from "./basePage";
import { Startup } from "../../../../Shared/spin-sys/tsc/helper/startup";

/**
 * Base class Home
 */
export class HomeHome extends BasePage {
	
	constructor() {
		super();
		
		this.value = $("#btn");
		this.value.on("click", this.Click)
	}

	
	private _value : JQuery<HTMLElement>;
	public get value() : JQuery<HTMLElement> {
		return this._value;
	}
	public set value(v : JQuery<HTMLElement>) {
		this._value = v;
	}
	

	public  Click()
	{
		alert("OK");
	}

	
	public Render(): void {
		this.header.Render();
		this.footer.Render();
	}
}

export default HomeHome;

Startup.Start(HomeHome);
