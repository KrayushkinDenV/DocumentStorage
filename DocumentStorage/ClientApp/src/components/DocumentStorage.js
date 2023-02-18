import React, { Component } from 'react';
import Button from "react-bootstrap/Button";


export class DocumentStorage extends Component {
    static displayName = DocumentStorage.name;

    constructor(props) {
        super(props);
        this.state = { achievements: [], loading: true };
    }

    componentDidMount() {
        this.loadDataAsync();
    }
    static renderAchievementsTable(achievements) {
        return (
            <table className='table table-striped' aria-labelledby="tabelLabel">
                <thead>
                    <tr>
                        <th>Title</th>
                        <th>FullTitle</th>
                        <th>Description</th>
                        <th>LinkToSource</th>
                    </tr>
                </thead>
                <tbody>
                    {achievements.map(achievement =>
                        <tr>
                            <td>{achievement.title}</td>
                            <td>{achievement.fullTitle}</td>
                            <td>{achievement.journalName}</td>
                            <td>{achievement.description}</td>
                            <td>{achievement.linkToSource}</td>
                        </tr>
                    )}
                </tbody>
            </table>            
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : DocumentStorage.renderAchievementsTable(this.state.achievements);
        return (
            <div>
                <h1 id="tabelLabel" >Achievements</h1>
                {contents}
            </div>
        );
    }

    async loadDataAsync() {
        const data = await fetch("/api/documentstorage",
            {
                method: 'GET'
            }).then(res => res.clone().json());

        this.setState({achievements: data, loading: false });
    }
}