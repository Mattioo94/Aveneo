import * as React from 'react';
import { RouteComponentProps } from 'react-router';
import { FindData } from "./FindData";

export class Home extends React.Component<RouteComponentProps<{}>, {}> {

    public render() {
        return <div id="form" className="form-group">
            <FindData />
        </div>;
    }
}
