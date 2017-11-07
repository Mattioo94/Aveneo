import * as React from 'react';

interface ShowResultProps
{
    Json: any
}

export class ShowResult extends React.Component<ShowResultProps, any> {

    public render() {
        return <div id="answer" className="form-group">
            <div className="alert alert-success">
                <strong>Znaleziono!</strong> Firma o podanym numerze NIP/KRS/REGON istnieje.
            </div>
            <div className="form-group">
                <div className="form-group">
                    <label htmlFor="name">Nazwa</label>
                    <input id="name" type="text" className="form-control" readOnly value={this.props.Json.name} />
                </div>
                <div className="form-group">
                    <label htmlFor="street">Ulica</label>
                    <input id="street" type="text" className="form-control" readOnly value={this.props.Json.street} />
                </div>
                <div className="form-group">
                    <label htmlFor="nr">Nr</label>
                    <input id="nr" type="number" className="form-control" readOnly value={this.props.Json.nr} />
                </div>
                <div className="form-group">
                    <label htmlFor="code">Kod Pocztowy</label>
                    <input id="code" type="text" className="form-control" readOnly value={this.props.Json.code} />
                </div>
                <div className="form-group">
                    <label htmlFor="city">Miasto</label>
                    <input id="city" type="text" className="form-control" readOnly value={this.props.Json.city} />
                </div>
            </div>
        </div>;
    }
}
