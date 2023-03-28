import React, { createContext, useState } from 'react'

import ResponsiveDialog from './CreateServiceModel'
import ServicesList from './ServicesList'

export const ServicesContext = createContext()

const Services = () => {

    const [data, setData] = useState([])

    const [open, setOpen] = useState(false)

    const [service, setService] = useState({
        id: '',
        name: '',
        time : '',
    })

    const AddService = async () => {
        if (service.id !== '') {

            const res = await fetch('https://localhost:44319/api/manager/addService',{
                method : 'POST',
                headers : {
                    'Content-Type': 'application/json'
                },
                body : JSON.stringify({
                    Name : service.name,
                    Time :  parseInt(service.time),
                })
            })

            const data = await res.json();

            console.log(data);

            var result = [];
            data.forEach(element => {
                if(element.id === service.id){
                    result.push(service)
                }else{
                    result.push(element);
                }
            });

            setData(result);




        } else {

            setData([...data, {
                ...service,
                id: data.length + 1
            }]);
        }
    }

    const deleteService = (service) => {
        var result = data.filter((ele) => ele.id !== service.id);
        setData(result);
    }

    return (
        <ServicesContext.Provider value={{
            data,
            setData,
            AddService,
            deleteService,
            service,
            setService,
            open,
            setOpen
        }} >
            <div className='mb_1' >
                <h1 className='mb_1' >Welcome !</h1>
                <h2>Manager Name</h2>
            </div>
            <div className='mb_1' >
                <ResponsiveDialog />

            </div>
            <div>
                <ServicesList />
            </div>
        </ServicesContext.Provider>
    )
}

export default Services