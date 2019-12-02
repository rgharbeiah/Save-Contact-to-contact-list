# Save-Contact-to-contact-list
used this code to create sitecore 9 Form  custom action to create/ update Contact to Contact list using Sitecore 9 Form.

using this code you can  add or update contact  depends on email address of contact, if the email address already exist then we update contact information , if the email address not exist then we add new contact 

I'm used the Email field as ID 
 var id = GetValue(emailField);//to sure that email address is unique 
 
 and add the follwing code to save contact to contact list 
 #region Save to contact to Contact list
                    SubscriptionService service = (SubscriptionService)ServiceLocator.ServiceProvider.GetService(typeof(ISubscriptionService));
                    Guid ListID = new Guid(Settings.GetSetting("ContactListID").ToString());// Get your Contact list ID
                    Guid contactID = new Guid(contact.Id.ToString());
                    service.Subscribe(ListID, contactID);
                    #endregion
                    
                    My code referance is 
https://doc.sitecore.com/developers/90/sitecore-experience-manager/en/walkthrough--creating-a-custom-submit-action-that-updates-contact-details.html

