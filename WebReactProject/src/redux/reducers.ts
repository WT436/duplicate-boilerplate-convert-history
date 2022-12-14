import { combineReducers } from 'redux';

import globalReducer from '../components/ComponentGlobal/reducer';

/**
 * Merges the main reducer with the router state and dynamically injected reducers
 */
export default function createReducer(injectedReducers = {}) {
    const rootReducer = combineReducers({
        global: globalReducer,
        ...injectedReducers
    });

    return rootReducer;
}