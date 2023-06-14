import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { DocumentStorage } from "./components/DocumentStorage";
import { CreateNewAuthor } from "./components/CreateNewAuthor";
import { CreateNewAchievement } from "./components/CreateNewAchievement";

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
        path: '/documentStorage',
        element: <DocumentStorage />
   },
   {
        path: '/createNewAuthor',
        element: <CreateNewAuthor />
    },
    {
        path: '/createNewAchievement',
        element: <CreateNewAchievement/>
    }
];

export default AppRoutes;
