import React from 'react'
import { useSelector, useDispatch } from 'react-redux'



export default function Account() {

    const user = useSelector(state => state.user.value);
    const allBills = useSelector(state => state.allBills.value);


    // Kullanıcının faturalarını filtrele
    const userBills = allBills.filter(bill => bill.userId==user.id);

    return (
        <div>

            <div className="entry-header-area">
                <div className="container mt-5">
                    <div className="row">
                        <div className="col-lg-12">
                            <div className="entry-header-title">
                                <h2>My-Account</h2>
                            </div>
                        </div>
                    </div>
                </div>
            </div>

            <div className="my-account-wrapper mb-70 mt-5">
                <div className="container">
                    <div className="section-bg-color">
                        <div className="row">
                            <div className="col-lg-12">

                                <div className="myaccount-page-wrapper">

                                    <div className="row">
                                        <div className="col-lg-3 col-md-4">
                                            <div className="myaccount-tab-menu nav" role="tablist">
                                                <a href="#dashboad" className="active" data-bs-toggle="tab">
                                                    <i className="fa fa-dashboard" />
                                                    Dashboard
                                                </a>
                                                <a href="#orders" data-bs-toggle="tab">
                                                    <i className="fa fa-cart-arrow-down" />
                                                    Orders
                                                </a>

                                                <a href="login.html">
                                                    <i className="fa fa-sign-out" /> Logout
                                                </a>
                                            </div>
                                        </div>

                                        <div className="col-lg-9 col-md-8">
                                            <div className="tab-content" id="myaccountContent">

                                                <div
                                                    className="tab-pane fade show active"
                                                    id="dashboad"
                                                    role="tabpanel"
                                                >
                                                    <div className="myaccount-content">
                                                        <h5>Dashboard</h5>
                                                        <div className="welcome">
                                                            <p>
                                                                Hello, <strong>{user.firstName}{" "}{user.lastName}</strong>
                                                            </p>
                                                        </div>

                                                    </div>
                                                </div>

                                                <div className="tab-pane fade" id="orders" role="tabpanel">
                                                    <div className="myaccount-content">
                                                        <h5>Orders</h5>
                                                        <div className="myaccount-table table-responsive text-center">
                                                            <table className="table table-bordered">
                                                                <thead className="thead-light">
                                                                    <tr>
                                                                        <th>Order</th>
                                                                        <th>Date</th>
                                                                        <th>Status</th>
                                                                        <th>Product Name</th>
                                                                        <th>Quantity</th>
                                                                    </tr>
                                                                </thead>
                                                                <tbody>
                                                                    {
                                                                        userBills && (
                                                                            userBills.map(bill => (
                                                                                <tr key={bill.id}>
                                                                                    <td>{bill.id}</td>
                                                                                    <td>{new Date().toLocaleDateString()}</td>
                                                                                    <td>{bill.isApproved ? "Onaylandı" : "Beklemede"}</td>
                                                                                    <td>
                                                                                        {bill.product.map(product => (
                                                                                            <div key={product.id}>
                                                                                                <span>{product.name}</span>
                                                                                            </div>
                                                                                        ))}
                                                                                    </td>
                                                                                    <td>
                                                                                        {bill.product.map(product => (
                                                                                            <div key={product.id}>
                                                                                                <span>{product.count}</span>
                                                                                            </div>
                                                                                        ))}
                                                                                    </td>
                                                                                </tr>
                                                                            ))
                                                                        )
                                                                    }
                                                                </tbody>
                                                            </table>

                                                        </div>
                                                    </div>
                                                </div>




                                            </div>
                                        </div>{" "}

                                    </div>
                                </div>{" "}

                            </div>
                        </div>
                    </div>
                </div>
            </div>


        </div>
    )
}
