import React from 'react'
import ChangeEmailModal from '../components/Modals/ChangeEmailModal'
import ChangePasswordModal from '../components/Modals/ChangePasswordModal'
import DeleteAccountModal from '../components/Modals/DeleteAccountModal'
import Navbar from '../components/Navbar/Navbar'

import './SettingsStyles.css';

function Settings() {
  return (
    
    <div>
      <Navbar/>
      <div className='settings-menu'>
    <ChangeEmailModal/>
    <ChangePasswordModal/>
    <DeleteAccountModal/>
    </div>
    </div>
  )
}

export default Settings