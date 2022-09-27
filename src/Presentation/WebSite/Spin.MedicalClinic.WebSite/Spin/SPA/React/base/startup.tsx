import * as React from "react";
import * as ReactDOM from "react-dom";
import { IStartup } from "./interface/IStartup";

export abstract class Startup implements IStartup {
	private spinContent=document.getElementById("SpinContent");
	constructor(value){
		this.ComponentMain = value;
	}

	public render()
	{
		var TagName = this.ComponentMain;

		ReactDOM.render(
			<React.StrictMode>
				<TagName {...this.spinContent.attributes}  part = {20}/>
			</React.StrictMode>,
			this.spinContent
		);
	}

	public ComponentMain: any;
}