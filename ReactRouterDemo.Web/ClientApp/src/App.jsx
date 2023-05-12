import React from 'react';
import { Route, Link } from 'react-router-dom';
import HomePage from './HomePage';
import PageOne from './PageOne';
import PageTwo from './PageTwo';
import Layout from './Layout';


function BorderedComponent({ children }) {
    return <div style={{ border: '4px solid red' }}>
        {children}
    </div>
}


class App extends React.Component {
    render() {
        return (
            <Layout>
                <Route exact path='/' component={HomePage} />
                <Route exact path='/PageOne' component={PageOne} />
                <Route exact path='/pagetwo' component={PageTwo} />
            </Layout>
        );
    }
};

export default App;