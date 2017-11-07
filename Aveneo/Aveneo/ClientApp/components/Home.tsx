import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { NavMenu } from "ClientApp/components/NavMenu";

interface MyComponentState { Answer: string }

export class Home extends React.Component<RouteComponentProps<{}>, MyComponentState> {

    constructor() {
        super();
        this.state = { Answer: '' };
        this.onSubmit = this.onSubmit.bind(this);
    }

    public render() {
        return <div>
            <div className="form-group">
                <label htmlFor="number">NIP/KRS/REGON</label>
                <input id="number" className="form-control" />
                <button onClick={this.onSubmit} className="btn btn-primary">Submit</button>
            </div>
                {this.state.Answer}
            <div id="answer" className="form-group">
            </div>
        </div>;
    }

    onSubmit = () => {

        var inputValue = (document.getElementById('number') as HTMLInputElement).value;

        var xhr = new XMLHttpRequest();
        xhr.open('get', `api/Companies/${inputValue}`, true);
        xhr.onload = () => {
            var response = JSON.parse(xhr.responseText);

            this.setState({
                Answer: response.name
            });

        }

        xhr.send();
    }
}
