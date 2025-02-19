import React, { Component } from 'react';
import AchievementInformCopy from "./page/Achievements/AchievementsCreate/AchievementInformCopy";

export class TestPage extends Component {
    static displayName = TestPage.name;
    constructor(props) {
        super(props);
    }
    render() {
        return (
            <AchievementInformCopy />
        );
    }
}