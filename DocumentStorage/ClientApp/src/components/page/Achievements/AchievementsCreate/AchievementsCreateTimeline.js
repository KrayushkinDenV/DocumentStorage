import AchievementInform from "./AchievementInform";
import AchievementInformCopy from "./AchievementInformCopy";
import AchievementFiles from "./AchievementFiles";
import React, { useState } from "react";
import tachyons from "tachyons";
import MultiStepProgressBar from "./MultiStepProgressBar";


import "./AchievementsCreateTimeline.css";

function AchievementsCreateTimeline() {
    const [page, setPage] = useState("achievementInform");
    const [id, setId] = useState();

    const nextPage = (page) => {
        setPage(page);
    };

    const saveId = (createdId) => {
        setId(createdId);
        nextPageNumber("2");
    };

    const nextPageNumber = (pageNumber) => {
        switch (pageNumber) {
            case "1":
                setPage("achievementInform");
                break;
            case "2":
                setPage("achievementFiles");
                break;
            case "3":
                alert("Ooops! In future, you can add authors in achievements!");
                break;
            default:
                setPage("1");
        }
    };

    return (
        <div className="AchievementsCreate">
            <MultiStepProgressBar page={page} />
            {
                {
                    achievementInform: <AchievementInformCopy onCreatedId={saveId} />,
                    //achievementInform: <AchievementInformCopy onPageNumberClick={nextPageNumber} />,
                    achievementFiles: <AchievementFiles/>,
                }[page]
            }
        </div>
    );

};

export default AchievementsCreateTimeline;