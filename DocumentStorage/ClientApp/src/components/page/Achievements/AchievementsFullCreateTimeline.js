import PageOne from "./PageOne/PageOne";
import PageTwo from "./PageTwo/PageTwo";
import PageThree from "./PageThree/PageThree";
import React, { useState } from "react";
import "./AchievementsFullCreateTimeline.css";
import tachyons from "tachyons";
import MultiStepProgressBar from "./MultiStepProgressBar/MultiStepProgressBar";

function AchievementsFullCreateTimeline() {
    const [page, setPage] = useState("pageone");

    const nextPage = (page) => {
        setPage(page);
    };

    const nextPageNumber = (pageNumber) => {
        switch (pageNumber) {
            case "1":
                setPage("pageone");
                break;
            case "2":
                setPage("pagetwo");
                break;
            case "3":
                setPage("pagethree");
                break;
            case "4":
                alert("Ooops! Seems like you did not fill the form.");
                break;
            default:
                setPage("1");
        }
    };

    return (
        <div className="AchievementsFullCreate">
            <MultiStepProgressBar page={page} onPageNumberClick={nextPageNumber} />
            {
                {
                    pageone: <PageOne onButtonClick={nextPage} />,
                    pagetwo: <PageTwo onButtonClick={nextPage} />,
                    pagethree: <PageThree onButtonClick={nextPage} />,
                    //pagefour: <PageFour />,
                }[page]
            }
        </div>
    );

};

export default AchievementsFullCreateTimeline;