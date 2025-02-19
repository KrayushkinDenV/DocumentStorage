import React, { Component } from 'react';
import AchievementsCreateTimeline from './AchievementsCreate/AchievementsCreateTimeline';

export class AchievementsCreate extends Component {
    static displayName = AchievementsCreate.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
                <AchievementsCreateTimeline/>
            </div>
        );
    }
}