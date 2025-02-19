import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { AchievementsIndex } from "./components/page/Achievements/AchievementsIndex";
import { AuthorsCreate } from "./components/page/Authors/AuthorsCreate";
import { AchievementsCreate } from "./components/page/Achievements/AchievementsCreate";
import { TestPage } from "./components/TestPage";

const AppRoutes = [
    {
        index: true,
        element: <Home />
    },
    {
        path: '/counter',
        element: <Counter />
    },
    {
        path: '/fetch-data',
        element: <FetchData />
    },
    {
        path: '/test-page',
        element: <TestPage />
    },
    {
        path: '/achievements/index',
        element: <AchievementsIndex />
    },
    {
        path: '/achievements/create',
        element: <AchievementsCreate />
    },
    {
        path: '/authors/create',
        element: <AuthorsCreate />
    }
];

export default AppRoutes;
