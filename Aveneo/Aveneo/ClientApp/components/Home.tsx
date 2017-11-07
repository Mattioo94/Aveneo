import * as React from 'react';
import { RouteComponentProps } from 'react-router';

export class Home extends React.Component<RouteComponentProps<{}>, {}> {
    public render() {
        return <div>
            <div className="form-group">
                <label htmlFor="number">NIP/KRS/REGON</label>
                <input id="number" className="form-control" />
                <button onClick={this.onSubmit} className="btn btn-primary">Submit</button>
            </div>
        </div>;
    }

    onSubmit = () => {

        var inputValue = (document.getElementById('number') as HTMLInputElement).value;

        var xhr = new XMLHttpRequest();
        xhr.open('get', `api/Companies/${inputValue}`, true);
        xhr.onload = () => {
            var response = JSON.parse(xhr.responseText);
            alert(response.name);
        }

        xhr.send();
    }
}
