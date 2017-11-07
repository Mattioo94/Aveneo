import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { NavMenu } from "ClientApp/components/NavMenu";
import { ShowResult } from "./ShowResult";

interface FindDataState {
    Res: any
}

export class FindData extends React.Component<any, FindDataState> {

    constructor() {
        super();
        this.state = {
            Res: null
        };

        this.onSubmit = this.onSubmit.bind(this);
    }

    public render() {
        return <div className="form-group">
            <div className="form-group">
                <label htmlFor="number">NIP/KRS/REGON</label>
                <input id="number" className="form-control" />
                <button onClick={this.onSubmit} className="btn btn-primary">Szukaj</button>
            </div>
            {this.state.Res}
        </div>;
    }

    onSubmit = () => {

        this.setState({
            Res: <div className="loader"></div>
        });

        var inputValue = (document.getElementById('number') as HTMLInputElement).value;

        var regexp = new RegExp('(^[0-9]{9,10}$)|(^[A-Z]{2}[0-9]{10}$)|(^[0-9]{3}-[0-9]{3}-[0-9]{2}-[0-9]{2}$)|(^[0-9]{3}-[0-9]{2}-[0-9]{2}-[0-9]{3})$');
        var correct = regexp.test(inputValue);

        if (correct)
        {
            var xhr = new XMLHttpRequest();
            xhr.open('get', `api/Companies/${inputValue}`, true);
            xhr.onload = () => {
                var response = JSON.parse(xhr.responseText);
                if (response != null) {
                    this.setState({
                        Res: <ShowResult Json={response} />
                    });
                }
                else {
                    this.setState({
                        Res: <div className="alert alert-danger">
                            <strong>Brak danych!</strong> Nie znaleziono wpisu o podanym numerze NIP/KRS/REGON.
                    </div>
                    });
                }
            }
            xhr.send();
        }
        else
        {
            this.setState({
                Res: <div className="alert alert-warning">
                    <strong>Uwaga!</strong> Podaj poprawny numer NIP/KRS/REGON.
                    </div>
            });
        }
    }
}
