import React, { Component } from 'react';
import Button from "react-bootstrap/Button";


export class AchievementsIndex extends Component {
    static displayName = AchievementsIndex.name;

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
                        <th></th>
                    </tr>
                </thead>
                <tbody>
                    {achievements.map(achievement =>
                        <tr>
                            <td>{achievement.title}</td>
                            <td>{achievement.fullTitle}</td>
                            <td>{achievement.journalName}</td>
                            <td>{achievement.description}</td>
                        </tr>
                    )}
                </tbody>
            </table>            
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : AchievementsIndex.renderAchievementsTable(this.state.achievements);
        return (
            <div>
                <h1 id="tabelLabel" >Achievements</h1>
                {contents}
            </div>
        );
    }

    async loadDataAsync() {
        const data = await fetch("api/achievements/index",
            {
                method: 'GET'
            }).then(res => res.clone().json());

        this.setState({achievements: data, loading: false });
    }
}