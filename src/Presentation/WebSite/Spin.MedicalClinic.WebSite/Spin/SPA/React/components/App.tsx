import * as React from "react";

export class App extends React.Component<{}, {}> {
	render() {
		return (
			<div className="content-data">
				<h1>
					WELCOME TO SPIN WEB FRAMEWORK - REACT JS
				</h1>
				<div className="row">
					<div className="col content-info">
						<img className="img-logo-info" src="/Spin/SPA/React/logo.svg" />
					</div>
					<div className="col content-info">
						<img className="img-logo-info" src="/spin-sys/dist/img/logo-spin-color.png" />
					</div>
				</div>
			</div>

		);
	}
}