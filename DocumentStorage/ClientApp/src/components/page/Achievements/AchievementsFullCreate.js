import React, { Component } from 'react';
import AchievementsFullCreateTimeline from './AchievementsFullCreateTimeline';

export class AchievementsFullCreate extends Component {
    static displayName = AchievementsFullCreate.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <AchievementsFullCreateTimeline/>
            </div>
        );
    }
}