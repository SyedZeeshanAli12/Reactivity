import React, {useState,useEffect} from 'react';
import './App.css';
import { ducks } from './demo';
import DuckItem from './DuckItem';
import axios from 'axios';
import {Header,List} from 'semantic-ui-react';
function App() {

  const [activities, setactivities] = useState([]);

  useEffect(() => {
    axios.get('http://localhost:5000/api/activities').then(response=>{
      console.log(response);
      setactivities(response.data);
    })
      }, [])

  return (
    <div>
      <Header as='h2' icon='users' content ='Reactivity'/>
      <List>
          {activities.map((activity:any)=>(
            <li key={activity.id}>
              {activity.title}
            </li>
          ))}
      </List>     
    </div>
  );
}

export default App;
