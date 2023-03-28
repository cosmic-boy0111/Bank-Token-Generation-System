import React, { createContext, useEffect, useState } from 'react'

import ResponsiveDialog from './CreateServiceModel'
import ServicesList from './ServicesList'

export const ServicesContext = createContext()

const Services = () => {

    const [data, setData] = useState([])

    const [open, setOpen] = useState(false)

    const getData = async () => {

        try {
            
            const res = await fetch('https://localhost:44319/api/manager/allServices',{
                method : 'GET',
                headers : {
                    'Content-Type': 'application/json'
                }
            })

            const resData = await res.json();
            console.log(resData);
            setData(resData);

        } catch (error) {
            
        }

    }


    useEffect(() => {
      getData();
    }, [])
    


    const [service, setService] = useState({
        Id: '',
        Name: '',
        Time: '',
    })

    const AddService = async () => {
        if (service.id !== '') {

            // to update the service

            const res = await fetch('https://localhost:44319/api/manager/updateService',{
                method : 'POST',
                headers : {
                    'Content-Type': 'application/json'
                },
                body : JSON.stringify({
                    Id : service.Id,
                    Name : service.Name,
                    Time :  parseInt(service.Time),
                })
            })

            const resData = await res.json();

            console.log(resData);

            getData();

            // var result = [];
            // data.forEach(element => {
            //     if (element.id === service.id) {
            //         result.push(service)
            //     } else {
            //         result.push(element);
            //     }
            // });

            // setData(result);




        } else {


            // to add a new service

            const res = await fetch('https://localhost:44319/api/manager/addService',{
                method : 'POST',
                headers : {
                    'Content-Type': 'application/json'
                },
                body : JSON.stringify({
                    Id : service.Id,
                    Name : service.Name,
                    Time :  parseInt(service.Time),
                })
            })

            const resData = await res.json();

            getData();
        }
    }

    const deleteService = async (service) => {

        console.log(service);

        const res = await fetch('https://localhost:44319/api/manager/deleteService', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                Id: service.Id
            })
        })

        const resData = await res.json();
        console.log(resData);

        getData();

        // var result = data.filter((ele) => ele.id !== service.id);
        // setData(result);
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