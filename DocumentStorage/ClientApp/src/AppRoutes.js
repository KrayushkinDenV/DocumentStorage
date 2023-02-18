import { Counter } from "./components/Counter";
import { FetchData } from "./components/FetchData";
import { Home } from "./components/Home";
import { DocumentStorage } from "./components/DocumentStorage"

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
   }
];

export default AppRoutes;
