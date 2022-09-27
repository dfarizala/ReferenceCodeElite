import React, { Component } from "react";

interface Props {
    id:string,
    x:string,
    callback?: () => void
}
interface State {
    element:any
}

export class HtmlCopy extends React.Component<Props, State> {
    constructor(props) {
        super(props);
        this.state = {
            element: document.querySelector(`react-html-copy#${this.props.id}`)
        };
    }

    componentDidMount() {
        this.props.callback();
    }

    getElementHtml = () => {
        return this.state.element ? this.state.element.firstElementChild.outerHTML: '';
    }

    render = () => {
        return <div className={this.props.x} dangerouslySetInnerHTML={{__html: this.state.element.firstElementChild.outerHTML}}></div>;
    }
}
export default HtmlCopy;