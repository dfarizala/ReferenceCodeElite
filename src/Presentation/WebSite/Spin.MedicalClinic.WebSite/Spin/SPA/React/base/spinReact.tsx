import { IStartup } from "./interface/IStartup"

export class SpinReact
{
	public static start(value:IStartup){
		this._startClass = value;
		SpinReact.startClass.render();
	}

	/**
	 * Start class of program
	 */
	private static _startClass : IStartup;

	/**
	 * Gets start class
	 */
	public static get startClass() : IStartup {
		return this._startClass;
	}

	/**
	 * Sets start class
	 */
	public static set startClass(v : IStartup) {
		this._startClass = v;
	}
}