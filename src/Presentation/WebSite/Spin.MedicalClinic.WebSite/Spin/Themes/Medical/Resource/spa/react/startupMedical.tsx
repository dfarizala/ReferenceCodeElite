import * as React from "react";
import * as ReactDOM from "react-dom";
import { App } from './app';
import { IStartup } from "../../../../../SPA/React/base/interface/IStartup";

export abstract class StartupMedical implements IStartup {
	private spinContent = document.getElementById("SpinContent");

	constructor(value) {
		this.ComponentMain = value;
	}

	public render() {
		return ReactDOM.render(
			<React.StrictMode>
				<App />
			</React.StrictMode>, this.spinContent);
	}

	public ComponentMain;
}