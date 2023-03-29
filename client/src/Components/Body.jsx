import React, { useContext } from 'react'
import { AppContext } from '../App'
import Manager from '../Layouts/Manager'



export const Body = () => {

    const {rootUser} = useContext(AppContext)

  return (
    <>
        <Manager />
    </>
  )
}
