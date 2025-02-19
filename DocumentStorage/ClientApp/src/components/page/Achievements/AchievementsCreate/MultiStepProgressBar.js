import React from "react";
import "./MultiStepProgressBar.css";
import { ProgressBar, Step } from "react-step-progress-bar";


//https://codesandbox.io/s/onboarding-cdf8fg?file=/src/index.js
const MultiStepProgressBar = ({ page }) => {
    var stepPercentage = 0;
    if (page === "achievementInform") {
        stepPercentage = 0;
    } else if (page === "achievementFiles") {
        stepPercentage = 50;
    } else if (page === "pagethree") {
        stepPercentage = 100;
    }
    else {
        stepPercentage = 0;
    }
//function MultiStepProgressBar(page) {
//    var stepPercentage = 0;
//    if (page === "achievementInform") {
//        stepPercentage = 0;
//    } else if (page === "achievementFiles") {
//        stepPercentage = 50;
//    } else if (page === "pagethree") {
//        stepPercentage = 100;
//    }
//    else {
//        stepPercentage = 0;
//    }    



    /*onClick={() => goToPage("1")}*/
    return (
        <ProgressBar percent={stepPercentage}>
            <Step>
                {({ accomplished, index }) => (
                    <div
                        className={`indexedStep ${accomplished ? "accomplished" : null}`}
                    >
                        {index + 1}
                    </div>
                )}
            </Step>
            <Step>
                {({ accomplished, index }) => (
                    <div
                        className={`indexedStep ${accomplished ? "accomplished" : null}`}
                    >
                        {index + 1}
                    </div>
                )}
            </Step>
            <Step>
                {({ accomplished, index }) => (
                    <div
                        className={`indexedStep ${accomplished ? "accomplished" : null}`}
                    >
                        {index + 1}
                    </div>
                )}
            </Step>
        </ProgressBar>
    );
};

export default MultiStepProgressBar;